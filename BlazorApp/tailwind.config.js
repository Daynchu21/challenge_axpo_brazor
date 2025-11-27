/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    "./**/*.{razor,html,cshtml}",
    "./Pages/**/*.razor",
    "./components/**/*.razor",
    "./Layout/**/*.razor",
    "./wwwroot/index.html",
  ],
  theme: {
    extend: {},
  },
  plugins: [],
};
