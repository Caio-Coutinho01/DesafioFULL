
import { NavMenuProjectComponent } from './nav-menu-project/nav-menu-project.component';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule,LOCALE_ID} from '@angular/core';
import { FormsModule,ReactiveFormsModule  } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { UsersComponent } from './users/users.component';
import { UserDataService } from './_data-services/user.data-service';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatToolbarModule,MatButtonModule,MatSidenavModule,MatIconModule
  ,MatListModule,MatInputModule,MatFormFieldModule,MatCardModule, MatDatepickerModule, MatTableModule } from '@angular/material';
  import { MatNativeDateModule } from '@angular/material/core';
  import localePt from '@angular/common/locales/pt';
  import {registerLocaleData} from '@angular/common';
  import { NgxMaskModule,IConfig } from 'ngx-mask'

  registerLocaleData(localePt)
  export const options: Partial<IConfig> | (() => Partial<IConfig>) = null;
 
@NgModule({
  declarations: [
    AppComponent,
    UsersComponent,
    NavMenuProjectComponent
  ],
  
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    MatToolbarModule,
    MatButtonModule,
    MatSidenavModule,
    MatIconModule,
    MatListModule,
    MatFormFieldModule,
    MatInputModule,
    MatCardModule,
    FormsModule,
    MatDatepickerModule,
    MatNativeDateModule,
    MatTableModule,
    ReactiveFormsModule ,
    NgxMaskModule.forRoot(),
    BrowserAnimationsModule
  ],
  providers: [UserDataService,{
    provide:LOCALE_ID,
    useValue:'pt-BR',
  }],
  bootstrap: [AppComponent]
})
export class AppModule { }
