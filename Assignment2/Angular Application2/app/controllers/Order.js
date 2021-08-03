app.controller("Order",function($scope,$http,ajax){
    ajax.get("https://localhost:44358/api/Order/GetAll",success,error);
    function success(response){
      $scope.Order=response.data;
    }
    function error(error){

    };

    $scope.details = function(p){
       
       invoice=p.InvoiceNumber;
   
     };

});