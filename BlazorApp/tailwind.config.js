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
    extend: {
      colors: {
        "text-primary": "#3D3D3D",
        "text-highlight": "#1F1F1F",
        surface: "#F8F8F8",
      },
      fontFamily: {
        lucida: ['"Lucida Console"', "monospace"],
        "open-sans": ['"Open Sans"', "sans-serif"],
      },
    },
  },
  plugins: [],
};
