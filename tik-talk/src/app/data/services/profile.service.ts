import {inject, Injectable} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {Profile} from "../interfaces/profile.interface";

@Injectable({
  providedIn: 'root'
})
export class ProfileService {
  http = inject(HttpClient);

  getTestAccounts(){
    return this.http.get<Profile[]>("https://localhost:5000/Profile/GetAllProfiles")
  }
}
