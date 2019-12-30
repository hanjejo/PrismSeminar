#동작순서
1. fuction을 EventManager의 Subscribe에 등록한다.
2. Event를 동작시킬 펑션에 publish fuction 배치

#구현 핵심
1. EventManager의 Subscribe에 구동 fuction 등록
2. 구독된 대상을 동작시킬 Publish 코드 배치
3. 넘기는 파라미터 Class가 존재할경우 EventArgs를 상속받아야함

#특징
각 객체간의 중간자 역할을 수행

#장점
1. 느슨하게 연결, 코드 결합도 낮아짐
2. 확장에 용이

#단점
1. 메시지 관리가 어려울 수 있음
