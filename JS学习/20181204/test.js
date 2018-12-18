$(function(){
	// //存储得到的值的方法
	// function factorial(n)
	// {
	// 	if(isFinite(n)&&n>0&&n==Math.round(n))
	// 	{
	// 	   if(!(n in factorial))
	// 	   {
 //              factorial[n]=n*factorial(n-1);
	// 	   }
	// 	   return factorial[n];
	// 	}
	// 	else
	// 		return NaN;
	// }
	// //不存储值的方法
	// function factorial2(n)
	// {
	// 	if(n<0)
	// 	{
	// 		return NaN;
	// 	}
	// 	else if(n==1)
	// 	{
 //            return 1;
	// 	}
	// 	else
	// 	{
	// 		return n*factorial2(n-1);
	// 	}
	// }
	// factorial[1]=1;
	// console.log(factorial(3));
	// console.log(factorial2(3));

 //    //函数闭包实现计数器
 //    function counter()
 //    {
 //    	var count=0;
 //    	return {
 //    	    getCount:function(){return n++;},
 //    	    setCount:function(){n=0;}
 //    	};
 //    }
 //    function counter1()
 //    {
 //    	var init=0;
 //        return {
 //            add:function(){return init++;}
 //        };
 //    }
 //    var counter=new counter1();
 //    console.log(counter.add());
 //    console.log(counter.add());
 //    console.log(counter.add());

    //对象属性的定义

    // typeof 会不同 instanceof 都可以

    // var a=new String("123");
    // console.log(a);
    // console.log(typeof(a));
    // console.log(a instanceof String);
    // console.log(a instanceof Object);

    // var b="456";
    // console.log(b);
    // console.log(typeof(b));
    // console.log(a instanceof String);
    // console.log(a instanceof Object);

    // var c=function(){};
    // console.log(typeof(c));
    // console.log(c instanceof Function);
    // console.log(c instanceof Object);
    
    // var a={};
    // var b="Name";
    // a["get"+b]=function(){console.log("123")};
    // a.getName();

    //遍历Array.prototype对象
    var testArray=['1','2','3','4'];
    // console.log(Array.prototype.slice.call(testArray,0,2));
    console.log(Array.prototype.splice.call(testArray,0,2,'10'));
    // testArray.splice(0,2);
    console.log(testArray);
})