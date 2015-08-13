
(function(){

    var app = angular.module("numberSequence",[]);

    var loginCtrl = function ($scope, loginService)
    {        
        $scope.user = {
            uservalue:'1',            
            error: '',
            numbers: '',
            odd_Numbers:'',
            even_Numbers: '',
            custom_Numbers: '',
            fibonacci_Numbers:''           
            
        };
        //Calling a service
        $scope.onUserSubmit = function (value) {
            loginService.getNumberSequence(value)
            .then(userComplete, errorResponse);
        };
        //On promise back success
        var userComplete = function (response) {

            $scope.user.numbers = response.numbers;
            $scope.user.odd_Numbers = response.oddnumbers;
            $scope.user.even_Numbers = response.evennumbers;
            $scope.user.custom_Numbers = response.customnumbers;
            $scope.user.fibonacci_Numbers = response.fibonaccinumbers;
            $scope.user.error = response.message;
            console.log("success");

        };
        //on promise back failure
        var errorResponse = function (response) {

            $scope.user.error = response;
            console.log("failure");
        };
        
    };
    //registering controller
    app.controller("userCtrl",loginCtrl );
}());