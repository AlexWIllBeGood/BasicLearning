$(function(){
	//加入变量的正则表达式
	var aString="123";
	var bString="abc12cc";
	var reg=new RegExp(".*"+aString+".*","gim");
	console.log(reg.test(bString));
   //Array中的filter函数
   var targetString="陈";
    var employeeNameRegExp=new RegExp(".*"+targetString+".*","gim");
    var array=[
    {"employeeName":"李恭洋","employeeIdCard":"421127"},
    {"employeeName":"陈新","employeeIdCard":"421128"},
    {"employeeName":"陈测试","employeeIdCard":"321127"},
    {"employeeName":"陈旧","employeeIdCard":"321128"}
    ];
    String.prototype.Contains=function(targetString){
    	return this.indexOf(targetString)>-1;
    }
    // var newArray=array.filter(e=>employeeNameRegExp.test(e.employeeName));
    // var newArray=array.filter(e=>e.employeeName.indexOf(targetString)>-1);
    var newArray=array.filter(e=>e.employeeName.Contains(targetString));
    console.log(newArray);
    console.log(array);
});