inHealthAssignmentApp.controller('BlogPostController', ['$http', '$scope', '$routeParams', '$location', 'BlogPostServices',
    function ($http, $scope, $routeParams, $location, BlogPostServices) {

        delete sessionStorage.UserId;

        var blogPostPublicUser = function () {
            $('.tr-ng-grid tbody tr.blank_row').remove();
            var htmlToAppend = '<tbody><tr class=blank_row><td colspan=13>No post found !!!</td></tr></tbody>';

            BlogPostServices.get(function (response) {
                $scope.BlogPostList = response.BlogPostList;
                console.log(response.BlogPostList);
                if (response.TotalCount == 0) {
                    $('.tr-ng-grid ').append(htmlToAppend);
                }
            });
        }

        blogPostPublicUser();

        $scope.RedirectToPostDetail = function (blogPostId) {
            sessionStorage.blogPostId = blogPostId;
            $location.path('/PostDetail');
        }

    }]);