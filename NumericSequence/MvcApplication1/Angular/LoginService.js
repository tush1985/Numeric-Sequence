(function () {

    

    var loginService = function ($http) {


        //Getting a NumberSequence by Calling to MVC controller
        var getNumberSequence = function (userValue) {

            return $http({
                url: '/Home/GetNumericSequenceValues',
                method: 'POST',                
                contentType: 'application/json',
                params: {uservalue: userValue }
                
                
            })            
           .then(function(response){
               return response.data;    
           });
        };


        return {
            getNumberSequence: getNumberSequence
        };


    };    
    var app = angular.module("numberSequence");
    //Registering a service
    app.factory("loginService", loginService);

}());