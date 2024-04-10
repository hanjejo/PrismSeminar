# MVVM 동작 순서
1. 사용자의 Action은 View를 통해 입력
2. View에 Action입력시, Command 패턴으로 ViewModel에 Action 전달
3. ViewModel은 Model에 데이터 요청
4. Model은 ViewModel에 요구 데이터 반환
5. ViewModel은 응답 받은 데이터를 가공하여 저장
6. View는 ViewModel과 Data Binding하여 화면 출력

# 구현 핵심
INotyfiedPropertyChanged 와 ICommand가 구현하는 것이 핵심

# 특징
MVVM에서 Command와 Data Binding을 사용하여 구현, View와 ViewModel 사이의 의존성 제거

# 장점
MVVM 패턴은 View와 Model 사이의 의존성이 없음
Command 패턴과 Data Binding을 사용하여 View와 ViewModel 사이의 의존성 또한 없앤 디자인패턴
각각의 부분은 독립적이기 때문에 모듈화 하여 개발 가능

# 단점
MVVM 패턴의 단점은 ViewModel의 설계가 쉽지 않음
