import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthService } from '../shared/services/auth.service';

@Component({
  selector: 'app-silent-refresh',
  templateUrl: './silent-refresh.component.html',
  styleUrls: ['./silent-refresh.component.scss']
})
export class SilentRefreshComponent implements OnInit {
  error: boolean;
  constructor(private authService: AuthService, private router: Router, private route: ActivatedRoute) { }

  async ngOnInit() {
    // check for error
    if (this.route.snapshot.queryParams.error) {
      this.error = true;
      return;
    }
    // check complete authen
    await this.authService.completeAuthentication();
    this.router.navigate(['/']);
  }
}
