(function(){
    function Circle(){
    }
    Circle.PI=3.1415926;
    Circle.area=function(){
    	return this;
    }
    Circle.area1=()=>{
    	return this;
    };
    console.log(Circle.area());
    console.log(Circle.area1());
    //箭头函数this指的是当前的文档对象
})();