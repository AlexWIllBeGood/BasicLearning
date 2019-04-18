#coding=utf-8
# dict={'name':'Alex','age':'25','gender':'male'}
# dict[3]='this is three'
# dict['one']='this is one'
# dict[2]='this is two' #无序的对象集合 2不能指代索引 变成了key
# print dict.keys()
# print dict.values()
#
# a=5
# b=3
# print a**b
# print pow(2,3)
# print a//b
#
#
# test_list=['1','2','3']
# print a in test_list
#
#
# #斐波那契函数递归写法
# def fibonacci(n):
#     if(n==1 or n==2):
#         return 1
#     else:
#         return fibonacci(n-1)+fibonacci(n-2)
#
# print fibonacci(4)
#
# c=[4,5,6]
# print c[:]
#
# #基本的判断语句
# score=95
# def get_assessment(score):
#     if score>90:
#         return 'great'
#     elif score>60:
#         return 'pass'
#     elif score>0:
#         return 'bad'
#
# print get_assessment(12)
# print get_assessment(61)
# print get_assessment(95)
#
# numbers=[34,67,34,66,78,90,5,67,89,4]
# def get_odd_and_even(numbers):
#     odd = []
#     even = []
#     while (len(numbers) > 0):
#         number = numbers.pop()
#         if (number % 2 == 0):
#             even.append(number)
#         else:
#             odd.append(number)
#     print odd
#     print even
#
# get_odd_and_even(numbers)
#
# #for循环
# letter="Python";
# fruits=["apple","banana","orange"]
# for l in letter:
#     print l
# for f in fruits:
#     print f

# print range(1,10,2)


# import math
# print dir(math)
#
# math.pow()

# import random
# # print random.random()
# # print random.randrange(1,10,2)

# import math
# print math.tan(math.pi/4) #PI为180

# test="test words"
# print test[1:]  #切片函数包含头 但是不包含尾

# print "123\n456"
# print r"123\n456"


# print "this is a test for {0}".format("Python")
#
# content="test\npython"
# print str(content)
# print repr(content)
#
# print str('''this is a
# test for
# python''')

# a='Hello World !'
# # encode_str=a.encode(encoding="base64",errors='strict')
# # print a
# # print encode_str

# words="this is a test for python encoding!";
# encoding_words=words.encode(encoding="Base64",errors="strict")
# print encoding_words

# unicode_words=u"this is \u unicode words"

# tuple_int=(3,45,67,899,45,3)
# list_int=[3,45,67,899,45,3]
# del tuple_int[2]
# print tuple_int

# dictionary={"a":"Test1","b":"Test2","a":"Test3"}
# print dictionary["a"]
#
# import time
# print time.time()

#本地时间
# import time
# localTime=time.localtime(time.time())
# print localTime
# asctime=time.asctime(localTime)
# print asctime


# import calendar
# cal=calendar.month(2019,1)
# print cal

# def TestList(list):
#     '''
#     to test weather the list will change or not
#     :param tuple:
#     :return:
#     '''
#     list.append(["test1"])
#
# target_list=["test","testNum"]
# print target_list
# TestList(target_list)
# print target_list

# def print_info(par,*varpar):
#     print "the first parameter is {0}".format(par)
#     tupleString=""
#     for i in varpar:
#         tupleString+=str(i)
#     print "the tuple is {0}".format(tupleString)
#
# print_info(20)
# print_info(20,30,40)

#lambda
# sum=lambda a,b:a+b
# print sum(2,4)
# print sum(5,4)

# from math import pow
# print pow(2,2)

# Money=2000
# def get_money():
#     global Money
#     Money=Money+1000
#
# print Money
# print get_money()

# import math
# print dir(math)

# list=[1,2,3,4,5,6]
# dict={}.fromkeys(list,'test')
# print dict

# Money=1000
# print globals()
# print locals()

# from TestPackage.SubPackage1 import function_in_package1
# from TestPackage.SubPackage2 import function_in_package2
#
# function_in_package1()
# function_in_package2()
#
# if __name__=="__main__":
#     print "this is main program"

# print "你输入的是{0}".format(input("请输入"))

# new_file=open("D:/TestFile.txt","w+")
# new_file.writelines("It's all for test")
# new_file.writelines("It will be all right")
# new_file.close()

# file=open("D:/TestFile.txt","r+")
# print file.read(40)
# print file.name
# print file.closed
# print file.mode
# file.close()

#测试文件定位 tell() seek()函数
# file=open("D:/TestFile.txt","r+")
# print file.read(2)
# print "current position is {0}".format(file.tell())
# file.seek(0,0)
# print "current position is {0}".format(file.tell())
# print file.read(2)
# file.close()

#测试重命名文件 rename() remove()函数
import os
# os.rename("D:/TestFile.txt","D:/NewName.txt")
# os.remove("D:/NewName.txt")

#测试文件夹的操作
#getcwd() mkdir() chdir() rmdir()
#使用字典去定义文件夹树结构
# import os
# base_dir="D:/"
# dir_tree={
#     "school1":{
#         "grade1":{
#             "class1":"Class1Content",
#             "class2":"Class1Content",
#         },
#         "grade2":{
#             "class1":"Class1Content",
#             "class2":"Class1Content",
#             "class3":"Class1Content"
#         }
#     },
#     "school2":{
#         "grade1":{
#             "class1":"Class1Content",
#             "class2":"Class1Content",
#             "class3":"Class1Content"
#         },
#         "grade2":{
#             "class1":"Class1Content",
#             "class2":"Class1Content",
#         }
#     }
# }
# def init_folder_tree(dict_folder_tree,base_dir):
#     if type(dict_folder_tree)==type({}):
#         if (dict_folder_tree.keys().__len__() > 0):
#             for folder_name in dict_folder_tree.keys():
#                 new_dir = os.path.join(base_dir, folder_name)
#                 new_folder_tree = dict_folder_tree[folder_name]
#                 os.mkdir(new_dir)
#                 init_folder_tree(new_folder_tree, new_dir)
#     else:
#         pass
# init_folder_tree(dir_tree,base_dir)

#!/usr/bin/python
# -*- coding: UTF-8 -*-

# import sys,time
# for i in range(30): #进度条类型
#     sys.stdout.write("*")
#     sys.stdout.flush()
#     time.sleep(0.2)

# try:
#     file.take()
# except BaseException as e:
#     print e.message
# finally:
#     print 123

# r r+ 不会主动创建
# temp=open("D:/123456.txt","r+")
# temp.write("this is a test file")
# temp.close()

















