$(function(){
	var stringValue=123;
	var numberValue="123";
	var booleanValue=true;
	var nullValue=null;     //Type:Object
	var undefinedValue=undefined;
	var arrayValue=["1","2","3"];
	var objectValue={"Name":"Alex","Age":2};
	var functionValue=function(){alert("123");};

	var dataArray=[];
	dataArray.push(stringValue);
	dataArray.push(numberValue);
	dataArray.push(booleanValue);
	dataArray.push(nullValue);
	dataArray.push(undefinedValue);
	dataArray.push(arrayValue);
	dataArray.push(objectValue);
	dataArray.push(functionValue);

    $.each(dataArray,function(index,item){
       console.log("Type:"+typeof(item)+" Value:"+item);
    });

//null 以及 array的数据类型都是 object
//     typeof "John"                 // 返回 string 
// typeof 3.14                   // 返回 number
// typeof NaN                    // 返回 number
// typeof false                  // 返回 boolean
// typeof [1,2,3,4]              // 返回 object
// typeof {name:'John', age:34}  // 返回 object
// typeof new Date()             // 返回 object
// typeof function () {}         // 返回 function
// typeof myCar                  // 返回 undefined (如果 myCar 没有声明)
// typeof null                   // 返回 object

   if(functionValue instanceof Function)
   {
   	  console.log("this is a function instance but the type is "+typeof(functionValue));
   }
   if(arrayValue instanceof Array)
   {
   	  console.log("this is a array instance but the type is "+typeof(arrayValue));
   }
});