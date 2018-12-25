$(function(){
	Vue.component('likeButton',{
       data:function(){
       	return {
       		count:0
       	}
       },
       props:['color','name'],
       template:"<button @click='count++' style='background-color:{{color}}'>{{name}}{{count}}</button>"
	})
	var temp=new Vue({
		el:"#app"
		})
})