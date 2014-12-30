var app = angular.module("BlogAwesome", ["kendo.directives"]);

app.controller("NavigationController", function ($scope) {
    $scope.menuOrientation = "horizontal";
    $scope.onSelect = function (ev) {
        console.log($(ev.item.firstChild).text());
    };
});



