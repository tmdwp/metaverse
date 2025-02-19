# metaverse
 
부트캠프 유니티 입문 개인과제 메타버스

Main
 이동 : 상하좌우키 및 WASD
 상호작용 : SpaceBar
 유령, 해파리와 상호작용 시 미니게임 이동

Flappy bird
 장애물에 부딪히지 않고 멀리 가기
 이동 : 스페이스바 및 마우스 좌클릭
 패배 시 스페이스바 및 좌클릭 -> 메인 이동

Ghost Hunt
 유령이 벽에 부딪히지 않게 사격하기
 이동 : 좌우키
 사격 : SpaceBar
 패배 시 스페이스바 -> 메인 이동

메인 맵 구조
 좌측 상단 : 점수표 - 최고 점수 확인 가능
 우측 : 미니게임 오브젝트




---
작성일 25.02.17
유니티 입문 개인과제 1일차

Scenes
# Main - 기본 씬, 미니게임 진입
# Flappy - 미니게임 1, Flappy Bird 게임 실행

Prefabs
# Clouds - Flappy의 배경, 카메라 밖으로 벗어나는 것을 방지
# Obstacle - Flappy의 장애물

Scripts
# FlappyMap - Flappy의 코드 폴더
## Camera - Flappy의 카메라 관리
## Manager - Flappy의 GameManager(시간 및 씬 내 점수 관리), UIManager(UI 출력 관리)
## Player - Flappy의 Player(조작, 충돌 시 패배 등)
## BgLooper - 장애물과 Clouds가 맵 밖으로 나갈 경우 재배치 실행
## Help - 설명문 출력 및 게임 시작
## Obstacle - 장애물 재배치 및 충돌 판정

# MainMap - Main의 코드 폴더
## Camera - Main의 카메라
## Player - Main의 Player(이동 및 상호작용)
## Minigame - 미니게임 이동 관리

# ScoreManager - 최고 점수 저장 및 관리

 Animations
# Flappy, Player - Flappy의 Player의 애니메이션

플레이어의 조작, 상호작용 및 미니게임 이동, Flappy Bird 구현 완료

 작성일 25.02.18
 유니티 입문 개인과제 2일차
# 타일맵, 상호작용 오브젝트 구현
# flappy의 일부 스프라이트 변경
# 새로운 미니게임 일부 구현 -> 총, 총알, 맵 구현
# 스크립트 미니게임 폴더 생성 -> flappy와 미완성된 미니게임의 스크립트 보관
#


 작성일 25.02.19
 유니티 입문 개인과제 3일차
# 미니게임 Ghost Hunt 구현
# Ghost Hunt의 몬스터 자동생성, 점수, 패배 구현
# 최고 점수를 보여주는 ScoreBoard 구현
# 최고 점수 저장 구현
---