$(function(){
	var s="123";
	s.len=4;
    console.log(s.len);
    var a="123";
    var A=new String(a);
    var b=null;
    var c=undefined;
    console.log(typeof(a)); //string
    console.log(typeof(A)); //object
    console.log(typeof(b)); //object
    console.log(typeof(c)); //undefined

    var d=["1","2","3"];
    //数组无法通过typeof来判断类型
    console.log(typeof(d));
    if(d instanceof Array)
    {
    	console.log("d is Array instance");
    }

    var numberTest=1;
    numberTest=2;
    console.log(numberTest);

    //测试作用域
    {
    var v1="123";
    let v2="1234";
    const v3="345";
    }
    console.log(v1);
    //let块级作用域不能能够访问
    // console.log(v2);
    //const块级作用域不能能够访问
    // console.log(v3);

    var nullValue=null;
    var undefinedValue=undefined;
    console.log("null:"+typeof(nullValue)+" undefined:"+typeof(undefinedValue));
    if(nullValue instanceof Object)
    {
    	console.log("null instance really");
    }
    if(undefinedValue instanceof Object)
    {
    	console.log("undefined instance really");
    }
    //null的typeof是object undefined 是undefined

    var stringValue="test";
    var numberValue=123;
    var arrayValue=[];
    var functionValue=function(){};
    var dateValue=new Date();
    console.log("string:"+typeof(stringValue));
    console.log("number:"+typeof(numberValue));
    if(stringValue instanceof String)
    {
    	console.log("string instance really");
    }
    if(numberValue instanceof Number)
    {
    	console.log("number instance really");
    }
    if(arrayValue instanceof Object)
    {
    	console.log("array instance really");
    }
    if(functionValue instanceof Object)
    {
    	console.log("function instance really");
    }
    if(dateValue instanceof Object)
    {
    	console.log("Date instance really");
    }
});