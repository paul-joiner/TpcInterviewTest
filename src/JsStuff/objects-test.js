require('chai').should();

describe('objects', function () {
    it('should return Bob John', function () {

        // TODO: 
        // complete this test so it imports objects.js into:
        Objects = require('object.js');
        var objects = new Objects();

        // Rewrite objects.getFullName() in objects.js to satisfy
        // this test condition
        objects.getFullname().should.equal('Bob John');

    });
});
