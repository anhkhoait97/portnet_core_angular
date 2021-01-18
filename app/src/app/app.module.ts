import { CommonModule } from '@angular/common';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AuthGuard } from './shared';
import { AuthInterceptor } from './shared/interceptors/auth.interceptor';
import { LanguageTranslationModule } from './shared/modules/language-translation/language-translation.module';
import { SilentRefreshComponent } from './silent-refresh/silent-refresh.component';

@NgModule({
    imports: [
        CommonModule,
        BrowserModule,
        BrowserAnimationsModule,
        HttpClientModule,
        LanguageTranslationModule,
        AppRoutingModule
    ],
    declarations: [AppComponent, SilentRefreshComponent],
    providers: [AuthGuard,
        {
            // using inceptors
            provide: HTTP_INTERCEPTORS,
            useClass: AuthInterceptor,
            multi: true
        }],
    bootstrap: [AppComponent]
})
export class AppModule { }
