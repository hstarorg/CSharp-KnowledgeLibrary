import { NgModule, ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { MainComponent } from './pages';

const routes: Routes = [
  { path: 'path', component: MainComponent },
];

export const routing: ModuleWithProviders = RouterModule.forRoot(routes, { useHash: false });
