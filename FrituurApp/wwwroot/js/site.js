// Winkelmandje en items bijhouden
const cart = [];
let cartTotal = 0;
let cartCount = 0;

// Voeg product toe aan het winkelmandje
function addToCart(product, price) {
    const existingItem = cart.find(item => item.product === product);

    if (existingItem) {
        // Als het product al in het winkelmandje zit, verhoog het aantal en de teller
        existingItem.quantity++;
        cartCount++;
    } else {
        // Als het product nog niet in het winkelmandje zit, voeg het toe en verhoog de teller
        cart.push({ product, price, quantity: 1 });
        cartCount++;
    }

    cartTotal += price;
    updateCartUI();
}

// Verwijder product uit het winkelmandje
function removeFromCart(product, price) {
    const existingItemIndex = cart.findIndex(item => item.product === product);

    if (existingItemIndex >= 0) {
        const existingItem = cart[existingItemIndex];

        if (existingItem.quantity > 1) {
            // Als er meer dan één exemplaar is, verminder het aantal en de teller
            existingItem.quantity--;
            cartCount--;
        } else {
            // Als er slechts één exemplaar is, verwijder het item en verminder de teller
            cart.splice(existingItemIndex, 1);
            cartCount--;
        }

        cartTotal -= price;
        updateCartUI();
    }
}

// Werk de UI van het winkelmandje bij
function updateCartUI() {
    const cartItems = document.getElementById('cart-items');
    const cartTotalElement = document.getElementById('cart-total');
    const cartCountElement = document.getElementById('cart-count');
    cartItems.innerHTML = '';

    cart.forEach(item => {
        const li = document.createElement('li');
        li.textContent = `${item.product} (Aantal: ${item.quantity}) - €${(item.price * item.quantity).toFixed(2)}`;

        // Voeg een verwijderknop toe
        const removeButton = document.createElement('button');
        removeButton.textContent = 'Verwijder';
        removeButton.addEventListener('click', () => {
            removeFromCart(item.product, item.price);
        });

        li.appendChild(removeButton);
        cartItems.appendChild(li);
    });

    cartTotalElement.textContent = `€${cartTotal.toFixed(2)}`;
    cartCountElement.textContent = cartCount;
}

// Toon/verberg het winkelmandje in de dropdown
function toggleCartDropdown() {
    const cartDropdown = document.getElementById('cart-dropdown');
    cartDropdown.classList.toggle('show');
}

// Voeg een eventlistener toe aan de knoppen om producten aan het winkelmandje toe te voegen
const addToCartButtons = document.querySelectorAll('.add-to-cart');
addToCartButtons.forEach(button => {
    button.addEventListener('click', () => {
        const product = button.getAttribute('data-product');
        const price = parseFloat(button.getAttribute('data-price'));
        addToCart(product, price);
    });
});
