
//var app = angular.module('App', []);


var app = angular.module('App', ['ngRoute']);

    app.config(['$locationProvider', function ($locationProvider) {
        $locationProvider.hashPrefix('');
    }]);

    app.config(function ($routeProvider) {
        $routeProvider
            .when('/', {
                controller: 'ListingsCtrl',
                templateUrl: '/App/Views/Listings.cshtml'

            })
            .when('/Listings', {
                controller: 'ListingsCtrl',
                templateUrl: '/App/Views/Listings.cshtml'
            })
             .when('/AgentListings', {
                 controller: 'AgentListingCtrl',
                 templateUrl: '/App/Views/AgentListings.cshtml'
             })
            
            .otherwise({ redirectTo: '/errorpage' });
        console.log("$routeProvider" + JSON.stringify($routeProvider));
    });





