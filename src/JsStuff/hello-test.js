/*
The test is already set up. Just look in hello.js and make the test pass. 
*/
require('chai').should();

describe('Hello', function () {
    it('should return hello', function () {
        // write a test to check if hello.js returns the string 'hello'
        var app = require('hello.js');
        return app._test.hello();
    });
});
