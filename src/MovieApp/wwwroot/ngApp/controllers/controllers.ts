namespace MovieApp.Controllers {

    export class HomeController {
        public message = 'Hello from the home page!';
        ///////////////////////
        private ProductResource;
        public product;
        public products;
        public getProducts() {
            this.products = this.ProductResource.query();
        }
        public save() {
            this.ProductResource.save(this.product).$promise.then(() => {
                this.product = null;
                this.getProducts();
            });
        }
        constructor(private $resource: angular.resource.IResourceService) {
            this.ProductResource = $resource('/api/products/:id');
            this.getProducts();
        }
    }
    export class AboutController {
        public message = 'Hello from the about page!';

        private CustomerResource;
        public customer;
        public customers;
        public getCustomers() {
            //this.customers = this.CustomerResource.query();
          //  console.log("request made");
          this.$http.get("/api/customers").then((_customers)=>{
              //console.log(customers);
              //dsfsfsdfssd
              this.customers = _customers.data;
          });
        }
        public save() {
            this.CustomerResource.save(this.customer).$promise.then(() => {
                this.customer = null;
                this.getCustomers();
            });
        }
        constructor(
            private $resource: angular.resource.IResourceService,
            private $http: angular.IHttpService) {
            this.CustomerResource = $resource('/api/customers');
            console.log("constructed");
            this.getCustomers();
        }
    }
}
