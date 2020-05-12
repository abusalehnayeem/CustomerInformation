import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FooterComponent } from './_layout/footer/footer.component';
import { TopbarComponent } from './_layout/topbar/topbar.component';
import { SidebarComponent } from './_layout/sidebar/sidebar.component';
import { ContentWrapperComponent } from './_layout/content-wrapper/content-wrapper.component';
import { CustomerListComponent } from './customer-list/customer-list.component';
import { InputsModule } from '@progress/kendo-angular-inputs';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { GridModule } from '@progress/kendo-angular-grid';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    FooterComponent,
    TopbarComponent,
    SidebarComponent,
    ContentWrapperComponent,
    CustomerListComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    InputsModule,
    BrowserAnimationsModule,
    GridModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
