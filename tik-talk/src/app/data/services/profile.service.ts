import {inject, Injectable} from '@angular/core';
import {HttpClient} from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class ProfileService {
  http = inject(HttpClient);

  getTestAccounts(){
    return this.http.get("https://localhost:5000/Profile/GetAllProfiles")
  }
}
