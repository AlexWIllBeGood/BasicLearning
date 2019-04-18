(function(){
	//闭包第一种
    // function Circle(r)
    // {
    // 	this.r=r;
    // }
    // Circle.PI=3.1415926;
    // Circle.prototype.area=function(){
    // 	return Circle.PI*Math.pow(this.r,2);
    // };
    // var c=new Circle(2);
    // console.log(c.area());

    //闭包第二种 只有函数有prototype属性
    // var Circle=function(r){
    // 	var obj=new Object();
    // 	obj.PI=3.1415926;
    // 	obj.r=r;
    // 	obj.area=function(){
    // 		return obj.PI*Math.pow(this.r,2);
    // 	}
    // 	return obj;
    // }
    // var c=Circle(2);
    // console.log(c.area());

    //闭包第三种 这种形式类似于面向过程编程 不是很适用
    // var Circle=new Object();
    // Circle.PI=3.1415926;
    // Circle.area=function(r){
    // 	return Circle.PI*Math.pows(r,2);
    // }
    // console.log(Circle.area(1));


    //闭包第四种 同样也类似于面向过程编程
    // var Circle={
    // 	'PI':3.1415926,
    // 	'area':function(r){
    //        return this.PI*Math.pow(r,2);
    // 	}
    // };
    // console.log(Circle.area(1));
})();