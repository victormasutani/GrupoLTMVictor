(function () {
    var app = angular.module('grupoLTMApp', ['ui.router', 'LocalStorageModule']);

    app.run(function ($rootScope, $location, $state, LoginService) {
        $state.go('login');
    });

    app.config(['$stateProvider', '$urlRouterProvider', function ($stateProvider, $urlRouterProvider) {
        $urlRouterProvider.otherwise('/login');

        $stateProvider
            .state('login', {
                url: '/login',
                templateUrl: 'view/login.html',
                controller: 'LoginController'
            })
            .state('home', {
                url: '/home',
                templateUrl: 'view/home.html',
                controller: 'HomeController'
            });
    }]);

    app.controller('LoginController', function ($scope, $rootScope, $stateParams, $state, LoginService, localStorageService) {
        $scope.formSubmit = function () {
            var resp = LoginService.login($scope.login, $scope.password);

            resp.then(function success(response) {  
                localStorageService.set('authorizationData', { token: response.data.access_token, userName: $scope.login });

                $state.go('home');
            }, (function error(err, status) {
                $scope.error = "Login ou senha incorreto!";
            }));
        };

    });

    app.controller('HomeController', function ($scope, $rootScope, $stateParams, $state, LoginService, ProductService) {
        ProductService.getProducts()
            .then(
            function (result) {
                if (result) {
                    $scope.data = result.data;
                }
            });
    });

    app.factory('LoginService', function ($http, $state) {
        return {
            login: function (login, password) {

                var data = "grant_type=password&username=" + login + "&password=" + password;

                return $http.post('http://localhost:53986/' + 'token', data, { headers: { 'Content-Type': 'application/x-www-form-urlencoded' } });
            }
        };
    });

    app.factory("ProductService", function ($http, $state) {
        
        var _getProducts = function () {
            return $http.get('http://localhost:53986/' + 'product/list');
        };

        return {
            getProducts: _getProducts
        };
    });

    app.factory('authInterceptorService', function ($q, $state, localStorageService) {

        var authInterceptorServiceFactory = {};

        var _request = function (config) {

            config.headers = config.headers || {};

            var authData = localStorageService.get('authorizationData');
            if (authData) {
                config.headers.Authorization = 'Bearer ' + authData.token;
            }

            return config;
        }

        var _responseError = function (rejection) {
            if (rejection.status === 401) {
                $state.go('login');
            }
        }

        authInterceptorServiceFactory.request = _request;
        authInterceptorServiceFactory.responseError = _responseError;

        return authInterceptorServiceFactory;
    });

    app.config(function ($httpProvider) {
        $httpProvider.interceptors.push('authInterceptorService');
    });


})();