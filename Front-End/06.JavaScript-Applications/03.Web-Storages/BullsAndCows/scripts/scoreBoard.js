define(["uiManager"], function (ui) {
    'use strict';

    var SCORES_KEY = 'bullsCowsScores',
        _countGuesses;

    function saveScore(countGuesses) {
        _countGuesses = countGuesses;
        ui.print('Please enter your nickname in the input box...')
        ui.showSubmitForm(onNameSubmit);        
    }

    function onNameSubmit(name) {
        var score = {
            name: name,
            score: _countGuesses
        };
        var scoreList = getScores();
        scoreList.push(score);
        scoreList = _.sortBy(scoreList, 'score');
        saveScores(scoreList);
        ui.showScores(scoreList);
    }

    function saveScores(scores) {
        localStorage.setItem(SCORES_KEY, JSON.stringify(scores));
    }

    function getScores() {
        return JSON.parse(localStorage.getItem(SCORES_KEY)) || [];
    }

    return {
        saveScore: saveScore
    }
});