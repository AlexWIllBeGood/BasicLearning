$(function(){
	var regex1 =/microsoft/i;
	var regex2=/apple/i;
	var text="this is a microsoft product";
    console.log("search function"+text.search(regex1));  //10
    console.log("search function"+text.search(regex2));  //-1

    console.log("replace function"+text.replace(regex1,"apple"));  
    console.log("replace function"+text.replace(regex2,"microsoft"));  

    console.log("test function"+regex1.test(text)); 
    console.log("test function"+regex2.test(text));

    var regex3=/1[a-zA-Z]+2/g;
    var text2="121d2";
    console.log("exec function "+regex3.exec(text2));


    //JS try catch 类似于C# 但是浏览器本身能将错误结果输出
    try{
    	addAlert("1234");
    }
    catch(err){
        alert(err);
    }

    //JS变量提升
    //JS严格模式 对浏览器版本有要求
    "use strict";
    y=1;

    //switch 执行时候使用的
    //对象与数组的操作 索引方式
    var arrayTemp=[];
    // arrayTemp[0].name="Alex";
    // arrayTemp[1].age=25;
    // arrayTemp[2].gender="male";
    arrayTemp[0]={"name":"Alex","age":25,"gender":"male"};

    alert(arrayTemp);

    
});