jQuery.support.cors=true;
var basicUrl="http://localhost:51179/BPO/Employee/"
$(function(){
    getBPOAllEmployeeInfo();
    // getBPOEmployeeById("SZ45002")
    // getBPOEmployeeByName("Alex")
    // emp={Name:"Jenney",Age:34,ID:"SZ45004"};
    // addBPOEmployee(emp)
    // getBPOAllEmployeeInfo();
    // emp1={Name:"Alex",Age:100,ID:"SZ45001"};
    // updateBPOEmployee(emp1);
    // emp2={Name:"Alex",Age:100,ID:"SZ45001"};
    // deleteBPOEmployee(emp2);
    // getBPOAllEmployeeInfo();
})
function getBPOAllEmployeeInfo()
{
   $.ajax({
   	url:basicUrl+"All",
   	type:'get',
   	dataType:'json',
   	success:function(res){
       var str="";
       if(res.Status=="y")
       {
       $.each(JSON.parse(res.Data),function(index,item){
          str+="第"+(index+1)+"个员工\r\n"+"姓名："+item.Name+" 年龄："+item.Age+"\r\n";
       });
       console.log(str);
       }
       else
       {

       }
   	},
   	error:function(msg)
   	{
   		alert(msg)
   	}
   });
}
function getBPOEmployeeById(id)
{
   $.ajax({
   	url:basicUrl+"GetById/"+id,
   	type:'get',
   	dataType:'json',
   	success:function(res){
       console.log(res);
   	},
   	error:function(msg)
   	{
   		alert(msg)
   	}
   });
}
function getBPOEmployeeByName(name)
{
   $.ajax({
   	url:basicUrl+"GetByName/"+name,
   	type:'get',
   	dataType:'json',
   	success:function(res){
       console.log(res);
   	},
   	error:function(msg)
   	{
   		alert(msg)
   	}
   });
}
function addBPOEmployee(emp)
{
   $.ajax({
   	url:basicUrl+"Add",
   	type:'post',
   	dataType:'json',
   	contentType:'application/json',
   	data:JSON.stringify(emp),
   	success:function(res){
       console.log(res);
       getBPOAllEmployeeInfo();
   	},
   	error:function(msg)
   	{
   		alert(msg)
   	}
   });
}
function updateBPOEmployee(emp)
{
   $.ajax({
   	url:basicUrl+"Update",
   	type:'post',
   	dataType:'json',
    data:JSON.stringify(emp),
    contentType:'application/json',
   	success:function(res){
       console.log(res);
       // getBPOAllEmployeeInfo();
   	},
   	error:function(msg)
   	{
   		alert(msg)
   	}
   });
}
function deleteBPOEmployee(emp)
{
   $.ajax({
   	url:basicUrl+"Delete",
   	type:'post',
   	dataType:'json',
   	data:JSON.stringify(emp),
   	contentType:'application/json',
   	success:function(res){
       console.log(res);
       // getBPOAllEmployeeInfo();
   	},
   	error:function(msg)
   	{
   		alert(msg)
   	}
   });
}