$(function(){
	function employee(name,age)
	{
		this.name=name;
		this.age=age;
	}
	var e1=new employee("Alex","25");
	//方法一
	employee.prototype.showName1=function(){
        console.log("showName1 name:"+this.name+" age"+this.age);
	};
	e1.showName1();
	//方法二
	employee.prototype={
		showName2:function(){
			console.log("showName2 name:"+this.name+" age"+this.age);
		}
	};
	var e2=new employee("Alex","25");
	e2.showName2();
	//方法三
	employee.prototype=function(){
        var showName3=function(){
        	console.log("showName3 name:"+this.name+" age"+this.age);
        }
        return {showName3:showName3};
	}();
	var e3=new employee("Alex","25");
	e3.showName3();

    //优秀的类似于switch的写法
	//深户 1
    ///城镇户口 2
    ///农村户口 3
    ///港澳台 4
    ///其他 5
    let options={
    	"1":function(name){
    		console.log(name+"的户籍类型是深户")
    	},
    	"2":(name)=>{
    		console.log(name+"的户籍类型是城镇户口")
    	},
    	"3":(name)=>{
    		console.log(name+"的户籍类型是农村户口")
    	},
    	"4":(name)=>{
    		console.log(name+"的户籍类型是港澳台")
    	},
    	"5":(name)=>{
    		console.log(name+"的户籍类型是其他")
    	},
    }
    options["1"]("Alex");
    options["2"]("Jane");
    options["3"]("John");
    options["4"]("Jack");
    options["5"]("Julie");
});