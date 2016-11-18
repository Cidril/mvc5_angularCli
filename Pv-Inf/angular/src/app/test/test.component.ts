import { Component, OnInit } from '@angular/core';
import { GetTextService } from '../shared/get-text.service';
import { TestClass } from '../shared/TestClass';

@Component({
    selector: 'app-test',
    templateUrl: './test.component.html',
    styleUrls: ['./test.component.css']
})
export class TestComponent implements OnInit {

    text = 'Display text here';
    testClass: TestClass = { id: 3, text: 'Test TExt' };

    constructor(private testService: GetTextService) { }

    onSelect(msg: string): void {
        this.testService.getText().subscribe(testClass => this.text = testClass.text);
    }

    ngOnInit() {
    }
  

}
