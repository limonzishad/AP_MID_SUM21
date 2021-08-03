app.controller("Cart",function($scope,$http,ajax){
    ajax.get("https://localhost:44386/api/Cart/GetAll",success,error);
    function success(response){
      $scope.Cart=response.data;
    }
    function error(error){

    };
    $scope.PlaceOrder = function(){
     
        ajax.post(API_ROOT+"api/Order/Add",
        function(resp){
          $location.path("/products");
        },function(err){});
      };

});