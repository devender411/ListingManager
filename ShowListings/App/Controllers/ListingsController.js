app.controller('ListingsCtrl', function ($scope, $http) {

    $scope.Listings = getListings();
    $scope.AgentListings = getAgentListings();
    function getListings() {
        $http.get('http://localhost:64566/Listings/Listings/')
     .then(function (response) {

         var data = response.data;
         var status = response.status;
         var statusText = response.statusText;
         var headers = response.headers;
         var config = response.config;

         $scope.Listings = data;
         console.log(JSON.stringify(data));
     });
    }

    $scope.delete = function (listing) {
        DeleteListing(listing);
    };
    function DeleteListing(id) {
        $http.get('http://localhost:64566/Listings/DeleteListings/'+id)
     .then(function (response) {

         var data = response.data;
         var status = response.status;
         var statusText = response.statusText;
         var headers = response.headers;
         var config = response.config;

         $scope.Listings = data;
         console.log(data);
     });
    }
    function getAgentListings() {
        $http.get('http://localhost:64566/AgentListings/Listings/')
     .then(function (response) {

         var data = response.data;
         var status = response.status;
         var statusText = response.statusText;
         var headers = response.headers;
         var config = response.config;

         $scope.Listings = data;
         console.log(JSON.stringify(data));
     });
    }
});
