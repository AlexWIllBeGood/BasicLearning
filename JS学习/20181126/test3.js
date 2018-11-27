$(function(){
   // var array=['1','2','3','4'];
   // console.log(array.valueOf());

   // var a="123";
   // console.log(a instanceof String);//false
   // var b=new String('234');
   // console.log(b instanceof String);//true

   // var employee={"Name":"123"};
   // console.log(employee.Name);//123
   // console.log(delete employee["Name"]);//true
   // console.log(employee.Name);//undefined

   //typeOf
   //原始对象看声明的方式1、字面量生成 2、构造函数生成
   // var a="123";
   // console.log(typeof(a));//string 
   // var b=new String("456");
   // console.log(typeof(b));//string  包装对象
  
  //枚举对象的属性
  // var a={};
  // a.name="Alex";
  // a.job="Engineer";
  // a.age=25;
  // for(b in a)
  // {
  // 	console.log(b+":"+a[b]);
  // }
  // throw
   // var a={};
   // a.GetError=function(x){
   // 	throw new Error(x+"is a number");
   // };
   // a.GetError(123);

   
   // var a={};
   // a.findMicrosoft=function(targetString){
   //    try{
   //       console.log(targetString.search(/microsoft/gim));
   //    }
   //    catch(ex){
   //    	console.log("i find a error:"+ex);
   //    }
   //    finally{
   //    	console.log("i will do it whatever happen!");
   //    }
   // }
   // a.findMicrosoft('456microsoft123');

   // var regExp=new RegExp('microsoft','gim');
   // console.log(regExp.test('microsoft'));

   //设置不可枚举属性
   // var person={
   // 	"name":"Alex",
   // 	"age":"25",
   // 	"gender":"male"
   // };
   // console.log(Object.keys(person));
   // Object.defineProperty(person,'name',{enumerable:false});//enumerable属性设置为false后就不显示在keys函数里面
   // console.log(Object.keys(person));
   
   // var arrayTest=['1','2','3'];
   // // console.log(Object.hasOwnProperty('keys'));
   // // console.log(Object.hasOwnProperty('toString'));
   // // console.log(JSON.stringify(arrayTest));
   // var temp=Object.keys(arrayTest);
   // $.each(temp,function(index,item){
   // 	  console.log(item);
   // })

   //splice函数的测试
  //  function TestSplice(array,p1,p2,p3,p4,p5)
  //  {
  //  	//splice函数其实可以有无数个参数
  //   //p1表示作用的位置
  //   //p2表示删除数量
  //   //p3以后表示插入的元素
  //  	var a=array.splice(p1,p2,p3,p4,p5,"infinity");
  //  	console.log(array);
  //  	console.log(a);
  //  }
  // var array=[1,2,3,4,5];
  // TestSplice(array,1,0,['a','b','c'],'b','c')

  // var arrayTest=['a','b','c'];
  // console.log(arrayTest.pop());
  // console.log(arrayTest);
  
  // forEach方法
  // var array=["a","b","c","d"];
  // array.forEach(function(v,i,a){
  //      console.log("第"+v+"个元素:"+i);
  //      console.log(a);
  // 	});

});