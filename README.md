# metaverse
 
#작성일 25.02.17
#유니티 입문 개인과제 1일차

# Scenes
## Main - 기본 씬, 미니게임 진입
## Flappy - 미니게임 1, Flappy Bird 게임 실행

# Prefabs
## Clouds - Flappy의 배경, 카메라 밖으로 벗어나는 것을 방지
## Obstacle - Flappy의 장애물

# Scripts
## FlappyMap - Flappy의 코드 폴더
### Camera - Flappy의 카메라 관리
### Manager - Flappy의 GameManager(시간 및 씬 내 점수 관리), UIManager(UI 출력 관리)
### Player - Flappy의 Player(조작, 충돌 시 패배 등)
### BgLooper - 장애물과 Clouds가 맵 밖으로 나갈 경우 재배치 실행
### Help - 설명문 출력 및 게임 시작
### Obstacle - 장애물 재배치 및 충돌 판정

## MainMap - Main의 코드 폴더
### Camera - Main의 카메라
### Player - Main의 Player(이동 및 상호작용)
### Minigame - 미니게임 이동 관리

## ScoreManager - 최고 점수 저장 및 관리

# Animations
## Flappy, Player - Flappy의 Player의 애니메이션

플레이어의 조작, 상호작용 및 미니게임 이동, Flappy Bird 구현 완료
