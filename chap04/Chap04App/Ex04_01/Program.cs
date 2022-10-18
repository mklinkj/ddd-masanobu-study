﻿using Ex04_01;

var userId = new UserId("id");
var userName = new UserName("nrs");
var user = new User(userId, userName);

// 새로 만든 객체에 중복 여부를 묻는 상황이 됨
var duplicateCheckResult = user.Exists(user);

// 구현을 따로 하지 않았으므로 결과는 항상 False 
Console.WriteLine(duplicateCheckResult); 
