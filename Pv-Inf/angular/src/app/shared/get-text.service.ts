import { Injectable } from "@angular/core";
import { Http, Response, Headers, RequestOptions } from "@angular/http";
import { Observable } from "rxjs/Rx";

import "rxjs/add/operator/map";
import "rxjs/add/operator/catch";

import { TestClass } from "./TestClass";

@Injectable()
export class GetTextService {
    url = "http://localhost:58349/";

    // private headers = new Headers({ "Content-Type": "application/json" });

    constructor(private http: Http) { }

    getText(): Observable<TestClass> {

        let textUrl: string = this.url + "api/Test/getText";
        let headers: Headers = new Headers({ "Content-Type": "application/json", "Accepts": "application/json" });
        let options: RequestOptions = new RequestOptions({ headers: headers });

        return this.http.get(textUrl, options)
            .map((res: Response) => res.json())
            .catch(this.handleError);
    }

    private handleError(error: any): Promise<any> {
        console.error("An error occurred", error); // for demo purposes only
        return Promise.reject(error.message || error);
    }

}