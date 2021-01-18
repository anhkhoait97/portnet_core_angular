import { environment } from './../../../environments/environment';
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { BaseService } from "./base.service";
import { UtilitiesService } from "./utilities.service";
import { catchError, map } from 'rxjs/operators';
import { User } from "../models/user.model";
import { Pagination } from "../models/pagination.model";

@Injectable({ providedIn: 'root' })
export class UserService extends BaseService {
    constructor(private http: HttpClient, private utilitiesService: UtilitiesService) {
        super();
    }

    private httpOptions = {
        headers: new HttpHeaders().set("Content-Type", "application/json"),
    };

    // add user
    add(entity: User) {
        // tslint:disable-next-line:max-line-length
        return this.http.post(`${environment.apiUrl}/api/User`, JSON.stringify(entity), this.httpOptions).pipe(catchError(this.handleError));
    }

    // update user
    update(id: string, entity: User) {
        // tslint:disable-next-line:max-line-length
        return this.http.put(`${environment.apiUrl}/user/` + id, JSON.stringify(entity), this.httpOptions).pipe(catchError(this.handleError));
    }

    // delete user
    delete(id: string) {
        return this.http.delete(environment.apiUrl + '/user/' + id, this.httpOptions).pipe(catchError(this.handleError));
    }

    // get detail user
    getDetail(id: string) {
        return this.http.get<User>(`${environment.apiUrl}/user/get-user-id/${id}`, this.httpOptions).pipe(catchError(this.handleError));
    }

    // get all user
    getAll(keyword?: any) {
        return this.http.get<User[]>(`${environment.apiUrl}/user/get-user?keyword=${keyword}`, this.httpOptions).pipe(catchError(this.handleError));
    }

    // get user paging
    getAllPaging(filter: any, pageIndex: any, pageSize: any) {
        // tslint:disable-next-line:max-line-length
        return this.http.get<Pagination<User>>(`${environment.apiUrl}/user/get-user-paging?pageIndex=${pageIndex}&pageSize=${pageSize}&filter=${filter}`, this.httpOptions)
            .pipe(map((response: Pagination<User>) => {
                return response;
            }), catchError(this.handleError));
    }

    // get menu for user role
    getMenuByUser(userId: string) {
        return this.http.get<Function[]>(`${environment.apiUrl}/user/${userId}/menu`, this.httpOptions).pipe(map(response => {
            const functions = this.utilitiesService.UnflatteringForTree(response);
            return functions;
        }), catchError(this.handleError));
    }

    // User Role
    getUserRoles(userId: string) {
        // tslint:disable-next-line:max-line-length
        return this.http.get<string[]>(`${environment.apiUrl}/user/${userId}/role`, this.httpOptions).pipe(catchError(this.handleError));
    }

    removeRolesFromUser(id: string, roleNames: string[]) {
        let rolesQuery = '';
        for (const roleName of roleNames) {
            rolesQuery += 'roleNames' + '=' + roleName + '&';
        }
        // tslint:disable-next-line:max-line-length
        return this.http.delete(environment.apiUrl + '/user/' + id + '/role?' + rolesQuery, this.httpOptions).pipe(catchError(this.handleError));
    }

    assignRolesToUser(userId: string, assignRolesToUser: any) {
        // tslint:disable-next-line:max-line-length
        return this.http.post(`${environment.apiUrl}/user/${userId}/role`, JSON.stringify(assignRolesToUser), this.httpOptions).pipe(catchError(this.handleError));
    }
}