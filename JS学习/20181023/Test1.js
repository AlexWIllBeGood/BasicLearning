$(function(){
	function People(name,age)
	{
		this.name=name;
		this.age=age;
	}
	//第一种方式给对象添加方法
    People.prototype.showname=function(){
    	console.log("Method1:"+"Name:"+this.name+" Age:"+this.age);
    }

    var p1=new People('Alex',20);

    p1.showname();
    
    //第二种方式给对象添加方法
    People.prototype={
    	showname2:function(){
    		console.log("Method2:"+"Name:"+this.name+" Age:"+this.age);
    	}
    }
    var p2=new People('Jane',22);
    p2.showname2();
    //第三种方式给对象添加方法(和第二种相似)
    People.prototype=function(){
        showname=function(){
        	console.log("Method3:"+"Name:"+this.name+" Age:"+this.age);
        }
    	return {showname3:showname}
    }();
    var p3=new People('Jack',25);
    p3.showname3();

    //js只有函数作用域以及全局作用域 Es6才引入会记作用域let 具有块级作用域
    function TestVar(){
    	// for(var i=0;i<100;i++)
    	// {

    	// }
    	// console.log("TestVar:"+i);
    	if(true)
    	{
    		var i=3;
    	}
    	console.log("TestVar:"+i);
    }
    function TestLet(){
    	// for(let i=0;i<100;i++)
    	// {

    	// }
    	// console.log("TestLet:"+i);
    	if(true)
    	{
    		let i=3;
    	}
    	console.log("TestLet:"+i);
    }
    TestVar();
    // TestLet();

    //JS中的事件
    $("#ShowDateBtn").bind('click',getDate);


    //JS字符串操作最好使用更强大的正则表达式
    var stringValue='now_Microsoft/123Microsoft'
    var pattern=/Microsoft/g;
    console.log(stringValue.search(pattern));

});
function getDate(){
       console.log("the time is "+Date());
    };