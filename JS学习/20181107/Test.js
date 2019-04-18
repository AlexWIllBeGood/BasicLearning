
$(function(){
	// JS中包含函数在内都是对象 
// var circle2=function(r){
//    var obj=new Object();
//    obj.r=r;
//    obj.PI=3.1415926;
//    obj.area=()=>{return obj.PI*obj.r*obj.r};
//    obj.radius=()=>{return obj.r};
//    obj.diameter=()=>{return 2*obj.r};	
//    return obj;
// };
// var c2=new circle2(3);
// alert(c2);
// alert(c2.area());
// alert(c2.radius());
// alert(c2.diameter());

//JS中prototype的作用 实际上是添加对象new关键字实例化后的值 假如不使用的话就类似于定义静态变量函数
// function People(name,age)
// 	{
//         //同样这里this.name this.age 也是对实例化对象的定义
// 		this.name=name;
// 		this.age=age;
// 	}	
//     //第三种方式给对象添加方法(和第二种相似)
//     People.prototype=function(){
//         showname=function(){
//         	console.log("Method3:"+"Name:"+this.name+" Age:"+this.age);
//         }
//     	return {showname3:showname}
//     }();
//     People.showname4=function(){
//     	console.log("Method3:"+"Name:"+this.name+" Age:"+this.age);
//     }
//     var p3=new People('Jack',25);
//     p3.showname3();
//     People.showname4();
//     //这里的People是一个函数
//     alert(People.name);

// 闭包的几种写法
// 第一种
// function circle(r)
// {
//     this.r=r;
// }
// circle.PI=3.1415926;
// //不加上prototype就变成了circle对象的属性
// //加上就变成了新的对象的属性
// circle.prototype.area=function(){
// 	return circle.PI*this.r*this.r;
// }
// var c=new circle(2);
// alert(c.area());
//第二种 和第一中没有大的区别
// var circle1=function(r){
// 	var obj=new Object();
//     obj.PI=3.1415926;
//     obj.r=r;
//     obj.area=function(){
//     	return obj.PI*this.r*this.r;
//     }
//     return obj;
// }
// var c1=new circle1(2);
// alert(c1.area());

//第三种
// var circle2=new Object();
// circle2.PI=3.1415926;
// circle2.area=function(r){
//    return this.PI*r*r;
// }
// var result=circle2.area(2);
// alert(result);

//第四种
// var circle3={
// 	"PI":3.1415926,
// 	"area":function(r){
//        return this.PI*r*r;
// 	}
// };
// alert(circle3.area(2));

//匿名函数的存在使得能够在函数内容定义内部函数，可以引用外部函数里的变量，在外部函数外面进行调用，形成闭包

//只有函数存在Prototype属性？
var tempFunction=function(){};
function displayProp(obj)
{
	for(var item in obj)
	{
		console.log("Name:"+item+" Value:"+obj[item]);
	}
}
displayProp(tempFunction);
});


