import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FooterComponent } from './_layout/footer/footer.component';
import { TopbarComponent } from './_layout/topbar/topbar.component';
import { SidebarComponent } from './_layout/sidebar/sidebar.component';
import { ContentWrapperComponent } from './_layout/content-wrapper/content-wrapper.component';


@NgModule({
  declarations: [
    AppComponent,
    FooterComponent,
    TopbarComponent,
    SidebarComponent,
    ContentWrapperComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
