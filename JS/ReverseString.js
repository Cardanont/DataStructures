// Create a function that reverses a string:


function reverseString(str) {
    // Check input
    if (!str || str.length < 2 || typeof str !== 'string') {
        return 'hmm that is not good';
    }

    const backwards = [];
    const totalItems = str.length - 1;

    for (let i = 0; i < totalItems; i--) {
        backwards.push(str[i]);
    }

    console.log(backwards);

    return backwards.join('');
}

function reverseString2(str) {
    return str.split('').reverse().join();
}

const reverseString3 = str => str.split('').reverse().join('');

reverseString3("Hi My name is Cardanont");