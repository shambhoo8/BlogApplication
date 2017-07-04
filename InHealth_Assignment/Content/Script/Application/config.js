﻿//Configure the routes
inHealthAssignmentApp.config(['$routeProvider', function ($routeProvider) {
    $routeProvider
    .when('/Home', {
        templateUrl: '../Home/BlogPost',
        controller: 'BlogPostController'
        })
    .when('/BlogPost', {
        templateUrl: '../Home/BlogPost',
        controller: 'BlogPostController'
        })
        .when('/BlogPostUser', {
            templateUrl: '../Home/BlogPostUser',
            controller: 'BlogPostUserController'
        })

        .when('/BlogPostList', {
            templateUrl: '../Home/BlogPostList',
            controller: 'BlogPostListController'
        })

    .when('/Login', {
        templateUrl: '../Home/Login',
        controller: 'LoginController'
        })

    .when('/UserRegistration', {
        templateUrl: '../Home/UserRegistration',
        controller: 'UserRegistrationController'
        })

    .when('/NewPost', {
        templateUrl: '../Home/NewPost',
        controller: 'NewPostController'
    })

    .when('/PostDetail', {
        templateUrl: '../Home/PostDetail',
        controller: 'PostDetailController'
        })

    .when('/UserList', {
        templateUrl: '../Home/UserList',
        controller: 'UserListController'
    })

    $routeProvider.otherwise({ redirectTo: '/Login' });
}]);


inHealthAssignmentApp.config(['$httpProvider', function ($httpProvider) {
    $httpProvider.interceptors.push('httpRequestInterceptor');
}]);