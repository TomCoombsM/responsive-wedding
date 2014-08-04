(function () {
    var app = angular.module("reservations", ["ngRoute"] );

    app.config(function ($routeProvider) {
        $routeProvider.when("/main", {
            templateUrl: "ng-views/main.html",
            controller : "MainController"
        })
        .otherwise({redirectTo:"/main"})
    });
}());