$(function(){
	//函数是一个对象
	//匿名函数自调用的写法
	// (function(){
	// 	alert(123);
	// })();

	//函数闭包实现计数器
	// var counter=function(){
	// 	var obj=new Object();
	// 	obj.start=0;
	// 	obj.count=function(){
	// 		console.log(this.start++);
	// 	}
	// 	return obj;
	// }();
	// counter.count();
	// counter.count();
	// counter.count();
	// JS闭包使得函数拥有私有变量成为可能


	//JS DOM
	//JS对象 一切皆对象
	//NaN 非数字判断
	// console.log(isNaN("string"));
	// console.log(isNaN(1));
	// var x=123;
	// var y=new Number(123);
	// console.log(typeof(x));
	// console.log(typeof(y));

	//JS使用prototype给JS对象创建新的方法和属性
    // Array.prototype.myUcase=function(){
    // 	for( var i=0;i<this.length;i++)
    // 	{
    // 		this[i]=this[i].toUpperCase();
    // 	}
    // }
    // var tempArray=['alex','jason','john'];
    // tempArray.myUcase();
    // $.each(tempArray,function(index,item){
    // 	console.log("Number:"+index+" Value:"+item);
    // });
    //JS Math对象 常用函数
    // var target=13.4;
    // var target1=16;
    // console.log("round function:"+Math.round(target));
    // console.log("round function:"+Math.ceil(target));
    // console.log("round function:"+Math.floor(target));
    // console.log("round function:"+Math.pow(target,2));
    // console.log("round function:"+Math.sqrt(target1));

    //window location href
    // console.log(location.href);
    // console.log(location.pathname);
    // location.assign("http://www.baidu.com")

    //window history
    //history.back()
    //history.forward()

    //window navigator
 //    txt = "<p>浏览器代号: " + navigator.appCodeName + "</p>";
	// txt+= "<p>浏览器名称: " + navigator.appName + "</p>";
	// txt+= "<p>浏览器版本: " + navigator.appVersion + "</p>";
	// txt+= "<p>启用Cookies: " + navigator.cookieEnabled + "</p>";
	// txt+= "<p>硬件平台: " + navigator.platform + "</p>";
	// txt+= "<p>用户代理: " + navigator.userAgent + "</p>";
	// txt+= "<p>用户代理语言: " + navigator.systemLanguage + "</p>";
 //    document.getElementById("example").innerHTML=txt;
    
    //JS计时事件
    // setInterval() - 间隔指定的毫秒数不停地执行指定的代码。
    // setTimeout() - 在指定的毫秒数后执行指定代码。
    //停止事件
    //clearInterval()
    //clearTimeout()

    //Jquery中的cookies操作
    // function People(name,age)
    // {
    // 	this.name=name;
    // 	this.age=age;
    // }
    // People.prototype.getInfo=()=>{
    // 	return "Name:"+this.name+" Age:"+this.age;
    // };
    // var p1=new People("Alex",25);
    // $.cookie("Info",p1.getInfo(),{expires:1,path:'/admin'});
    // $.cookie("Object",p1,{expires:1});
    // console.log(document.cookie);
});