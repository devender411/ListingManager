app.controller('AgentListingCtrl', function ($scope, $http) {

    $scope.AgentListings = getAgentListings();
    function getAgentListings() {
        $http.get('http://localhost:64566/AgentListings/Listings/')
     .then(function (response) {

         var data = response.data;
         var status = response.status;
         var statusText = response.statusText;
         var headers = response.headers;
         var config = response.config;

         $scope.AgentListings = data;
         console.log(JSON.stringify(data));
     });
    }
});
