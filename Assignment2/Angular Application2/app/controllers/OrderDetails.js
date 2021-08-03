app.controller("OrderDetails",function($scope,$http,ajax){
   
    ajax.get("https://localhost:44358/api/OrderDetail/GetAll/"+invoice,success,error);
    function success(response){
      $scope.OrderDetail=response.data;
    }
    function error(error){
    }
    
});