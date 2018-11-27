$(function(){
	//this表示上下文
	// var o={
	// 	m:function(){
	// 	   var self=this;
	// 	   debugger;
	// 	   console.log("1"+(o===this));
	// 	   console.log(this);
	// 	   console.log("2"+(o===self));
 //           f();
 //           //这个函数不属于对象o，因此属于window对象，因此this上下文是window
	// 	   function f(){
	// 	   	debugger;
	// 	   	console.log("3"+(this===o));//this其实是window对象
	// 	   	console.log(this);
	// 	   	console.log("4"+(self===o));
	// 	   }
	// 	},
	// 	flag:true
	// };
	// o.m();

	//函数 可选参数
	// function getPropertyName(o,a)
	// {
	// 	var a=a||[];
	// 	for(p in o)
	// 	{
	// 		a.push(p);
	// 	}
	// 	return a;
	// }
	// obj1={"name":"Alex","age":25,"gender":"male"};
	// obj2={"title":"Engineer","position":"middle"};
	// var temp=getPropertyName(obj1);
 //    console.log(getPropertyName(obj2,temp));


    //JS函数不支持 不按照顺序去传递参数 需要自己手动实现 具体的方法是传入对象
    // var testPara=function(name,age)
    // {
    // 	console.log("name:"+name+" "+"age:"+age);
    // }
    // testPara(age=12,name="Alex"); //name=12 age=Alex
    
    
});