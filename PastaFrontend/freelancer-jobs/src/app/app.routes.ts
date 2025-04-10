import { Routes } from '@angular/router';
import { LoginComponent } from './pages/login/login.component';
import { RegisterComponent } from './register/register.component';
import { ProjectDashboardComponent } from './project-dashboard/project-dashboard.component';
import { NewProjectComponent } from './pages/new-project/new-project.component';

export const routes: Routes = [
  { path: 'login', component: LoginComponent },
  { path: 'register', component: RegisterComponent },
  { path: 'projects', component: ProjectDashboardComponent },
  { path: '', redirectTo: 'login', pathMatch: 'full' },
  {path: 'novo-projeto', component: NewProjectComponent },
];
