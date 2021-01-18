import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { routerTransition } from '../router.animations';
import { AuthService } from '../shared/services';

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.scss'],
    animations: [routerTransition()]
})
export class LoginComponent implements OnInit {
    constructor(public router: Router, private authService: AuthService, private spinner: NgxSpinnerService) { }

    ngOnInit() { }

    onLoggedin() {
        this.spinner.show();
        this.authService.login();
    }
}
