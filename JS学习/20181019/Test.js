// $(function(){
// 	layui.use('layer',function(){
// 		var layer=layui.layer;
// 		layer.load(1,{shade:[0.5,'#8C5E91'],time:3000});
// 	})
// });
$(function(){
	// JS的数据类型
	//值类型对象 string number boolean null undefined symbol
	//引用类型对象 array function object
	var stringValue="Test";
	var numberValue=1.23e8;
	var boolValue=true;
	var nullValue=null;
	var undefinedValue=undefined;
	console.log("string:"+stringValue);
	console.log("number:"+numberValue);
	console.log("boolean:"+boolValue);
	console.log("null:"+nullValue);
	console.log("undefined:"+undefinedValue);

	var employeeArray=new Array();
	var employee1={name:"Alex",age:25,job:"Engineer"};
	var employee2={name:"Jason",age:23,job:"Designer"};
	var employee3={name:"John",age:24,job:"Artist"};
	employeeArray.push(employee1);
	employeeArray.push(employee2);
	employeeArray.push(employee3);

	$.each(employeeArray,function(index,item){
       var tempString="Index:"+index+" Name:"+item.name+" age:"+item.age+" job:"+item.job;
       console.log(tempString);
	});
});