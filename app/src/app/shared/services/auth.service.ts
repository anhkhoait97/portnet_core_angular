import { Injectable } from "@angular/core";
import { User, UserManager, UserManagerSettings } from "oidc-client";
import { BehaviorSubject } from "rxjs";
import { Profile } from "../models";
import { BaseService } from "./base.service";


@Injectable({
    providedIn: 'root'
})
export class AuthService extends BaseService {
    // Observable navItem source
    private _authNavStatusSource = new BehaviorSubject<boolean>(false);
    // Observable navItem stream
    authNavStatus$ = this._authNavStatusSource.asObservable();

    // get configuration angular
    private manager = new UserManager(getClientSettings());
    private user: User | null;

    constructor() {
        super();

        this.manager.getUser().then(user => {
            this.user = user;
            this._authNavStatusSource.next(this.isAuthenticated());
        });
    }

    login() {
        return this.manager.signinRedirect();
    }

    async completeAuthentication() {
        this.user = await this.manager.signinRedirectCallback();
        this._authNavStatusSource.next(this.isAuthenticated());
    }

    isAuthenticated(): boolean {
        return this.user != null && !this.user.expired;
    }

    get authorizationHeaderValue(): string {
        if (this.user) {
            return `${this.user.token_type} ${this.user.access_token}`;
        }
        return null;
    }

    get profile(): Profile {
        return this.user != null ? this.user.profile : null;
    }

    get name(): string {
        return this.user != null ? this.user.profile.name : '';
    }

    async signout() {
        await this.manager.signoutRedirect();
    }
}

// function get configuration identity server 4
export function getClientSettings(): UserManagerSettings {
    return {
        authority: 'https://localhost:5000',
        client_id: 'angular_admin',
        redirect_uri: 'http://localhost:4200/auth-callback',
        post_logout_redirect_uri: 'http://localhost:4200',
        silent_redirect_uri: 'http://localhost:4200/silent-refresh',
        response_type: 'code',
        scope: 'openid profile api.portnet', // scope mapp identity
        filterProtocolClaims: true,
        loadUserInfo: true,
        automaticSilentRenew: true,
        accessTokenExpiringNotificationTime: 4
    };
}
