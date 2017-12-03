import { ClientUIPage } from './app.po';

describe('client-ui App', () => {
  let page: ClientUIPage;

  beforeEach(() => {
    page = new ClientUIPage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('Welcome to app!');
  });
});
