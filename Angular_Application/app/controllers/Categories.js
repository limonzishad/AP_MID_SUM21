app.controller("Categories",function($scope,$http,ajax){
  ajax.get("https://localhost:44358/api/Category/GetAll",success,error);
  function success(response){
    $scope.Categories=response.data;
  }
  function error(error){

  }

});