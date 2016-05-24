angular.module('FsApp', [])
    .controller('FsController', function($scope, $http) {
        function show(data) {
            $scope.currentpath = data.Path;
            $scope.less10mb = data.Less10Mb;
            $scope.between10and50mb = data.Between10And50Mb;
            $scope.more100mb = data.More100Mb;
            $scope.objects = data.Objects;
        }
        $http.get("/api/filesystem").success(function(data) {
            show(data);
        });

        $scope.movetofolder = function(path) {
            $http.get("/api/filesystem/" + path).success(function (data) {
                show(data)});
        };
    })