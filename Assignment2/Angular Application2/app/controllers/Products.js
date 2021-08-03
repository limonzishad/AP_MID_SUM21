  
app.controller("Products",function($scope,$http,ajax){
  ajax.get("https://localhost:44358/api/Product/GetAll",success,error);
  function success(response){
    $scope.Products=response.data;
  }
  function error(error){

  };
  $scope.addtocart = function(d){
   
    ajax.post(API_ROOT+"api/Cart/Add",d,
    function(resp){
      $location.path("/cart");
    },function(err){});
  };

});