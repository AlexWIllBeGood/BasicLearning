$(function(){
	// ECMAscript标准中数组的函数
	//foreach函数
	// var arrayTest=[4,5,3,6,7,8,1];
	// arrayTest.forEach(function(i,v,a){
 //        console.log("第"+v+"个元素是："+i,"the array is:"+a.valueOf());
	// });
	//map函数 返回一个数组
	// var newArray=arrayTest.map(function(x){
	// 	return 2*x+1;
	// });
	// $.each(newArray,function(index,item){
 //       console.log("第"+index+"个元素是："+item);
	// });
    //filter函数
    // function showMultiDimensionArray(targetArray)
    // {
    // 	$.each(targetArray,function(index,item){
    //         var temp="";
    //         for(a in item)
    //         {
    //         	temp=temp+item[a]+" ";
    //         }
    //         console.log(temp);
    // 	});
    // }
    // var sparseArray=[[1,2,3],[4,4,4],[5,7],[3,9]];
    // var sparseArray1=[];
    // sparseArray1[0]=[3,4,5];
    // sparseArray1[100]=[6,4,6];
    // showMultiDimensionArray(sparseArray);
    // var dense=sparseArray.filter(function(){return true});
    // showMultiDimensionArray(dense);

    // filter函数
    // //利用filter能去除稀疏数组中的空白的特性 获得稠密数组 
    // showMultiDimensionArray(sparseArray1);
    // var dense1=sparseArray1.filter(function(){return true});
    // showMultiDimensionArray(dense1);

    // var employees=function(){
    // 	var obj={};
    // 	obj.employees=[];
    // 	obj.AddEmployee=function(name,age,title){
    // 		var employee={"name":name,"age":age,"title":title};
    // 		this.employees.push(employee);
    // 	}
    // 	obj.ShowAllEmployees=function(siftFunction){
    // 		var temp=this.employees.filter(siftFunction);
    // 		$.each(temp,function(index,item){
    //             console.log("name:"+item["name"]+" "+"age:"+item["age"]+" "+"title:"+item["title"]);
    // 		});
    // 	}
    // 	return obj;
    // }();
    //正则表达式筛选员工
    // employees.AddEmployee("Alex",25,"Engineer");
    // employees.AddEmployee("Jason",30,"Manager");
    // employees.AddEmployee("Jane",38,"Leader");
    // employees.AddEmployee("Ann",21,"Engineer");
    // employees.AddEmployee("Bob",15,"Manager");
    // //避免因为lastIndex更改位置造成错误
    // // var reg=new RegExp('^j.*','im');
    // employees.ShowAllEmployees(function(emp){return emp.age>21;});
    // console.log("get employees whose name start with capital j");
    // employees.ShowAllEmployees(function(emp){return new RegExp('^j.*','im').test(emp.name)});
    // console.log("get employees whose name start with capital j");
    // employees.ShowAllEmployees(function(emp){return new RegExp('.*Engineer.*').test(emp.title)});

    //some 以及 every函数
    // var employees=function(){
    // 	var obj={};
    // 	obj.employees=[];
    // 	obj.AddEmployee=function(name,age,title){
    // 		var employee={"name":name,"age":age,"title":title};
    // 		this.employees.push(employee);
    // 	}
    // 	return obj;
    // }();
    // employees.AddEmployee("Alex",25,"Engineer");
    // employees.AddEmployee("Jason",30,"Manager");
    // employees.AddEmployee("Jane",38,"Leader");
    // employees.AddEmployee("Ann",21,"Engineer");
    // employees.AddEmployee("Bob",15,"Manager");
    // console.log(employees.employees.every(function(x){return x.age<38;}));
    // console.log(employees.employees.some(function(x){return x.age<25;}));

    //reduce函数和reduceRight函数 折叠函数 按照函数定义进行折叠
    // var a=[1,2,3,4,5,6];
    // var sum=a.reduce(function(accumulator,item,index,array){
    // 	return accumulator+item
    // },2);
    // console.log(sum);

    //indexOf lastIndexOf 查找数组中有给定值的位置

    //数组类型 isArray()函数 判断数组类型的方法
    // var a=[];
    // console.log(typeof a);
    // console.log(a instanceof Array);
    // console.log(Array.isArray(a));

    //类数组对象
    // var a={"0":"a","1":"b","2":"c",length:3};
    // console.log(a.length);
    // //a.forEach(function(){});//不能够直接调用
    // console.log(Array.prototype.join.call(a,'+'));
    // // console.log(Array.prototype.splice.call(a,0,0));
    // console.log(Array.prototype.map.call(a,function(item,index,a){
    // 	return item.toUpperCase();//变成了数组
    // }));

});