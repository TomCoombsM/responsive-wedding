(function () {
    var app = angular.module("reservations");
    var MainController = function ($scope, $http) {
        $scope.name = "tomdd";


        

        $scope.search = function (name) {
            var person = {
                Name: $scope.name,
                Email: $scope.email
            }
            $http.post("/person/",person);
        }
    }
    
    app.controller("MainController", MainController)
}());